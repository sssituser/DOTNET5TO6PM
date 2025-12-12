import React,{useState} from "react";
export default function Login(){

    const[name,setName]=useState('kiran kumar')
    function updateInput(event){
        setName(event.target.value)
    }
    return (
        <React.Fragment>
            <p className="display-4 text-center">Login Component</p>
            <div className="container text-center">
                    <input type="text" onChange={updateInput} name={name} value={name}
                     style={{height:40,width:300,fontSize:35}} />
                    
                    <p className="display-4">Name : {name}</p>
            </div>
        </React.Fragment>
    )
}