import React,{useState,useEffect}from "react";
import axios from 'axios'
export default function Home(){
    let[search,setSearch]=useState('') // 1

    let[users,setUsers]=useState([])    
   
    const filteredUsers=users.filter((user)=>`${user.id}${user.name}${user.email}${user.username}`.toLowerCase().includes(search.toLowerCase()))
    
    function updateInput(event){
        setSearch(
            search=event.target.value
        )
    }
   
    useEffect(()=>{
        axios.get("https://jsonplaceholder.typicode.com/users") 
        .then((response)=>{
            setUsers(response.data)
        })
        .catch((error)=>{alert(error)})
    },[])


    return (
        <React.Fragment>
            <p className="display-4 text-center">Home Component</p>

            <div className="container">
                <div className="row">
                    <div className="col-md-4">
                        <input type="text"
                         name='search'
                         value={search}
                         onChange={updateInput}
                        className="form-control" placeholder="Search By ID/Name/UserName/Email" />
                    </div>
                </div>
            </div>

            <div className="container text-center mt-lg-5">
                {
                    filteredUsers.length>0 ? 
                    <table className="table table-bordered table-striped table-hover">
                        <thead className="bg-secondary text-white text-center">
                            <tr>
                                <th>ID</th>
                                <th>Name</th>
                                <th>User Name</th>
                                <th>Email</th>
                                <th>City</th>
                                <th>Suite</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                filteredUsers.map((user)=>{
                                    return(
                                        <tr>
                                            <td>{user.id}</td>
                                            <td>{user.name}</td>
                                            <td>{user.username}</td>
                                            <td>{user.email}</td>
                                            <td>{user.address.city}</td>
                                            <td>{user.address.suite}</td>
                                        </tr>
                                    )
                                })
                            }
                        </tbody>
                    </table>
                    :
                    <p className="h3 text-danger">Records Not Found</p>
                }
            </div>


       
        </React.Fragment>
    )
}