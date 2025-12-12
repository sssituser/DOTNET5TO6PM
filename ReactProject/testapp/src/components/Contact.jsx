import React,{useState} from "react";
import { jsxs } from "react/jsx-runtime";

export default function Contact(){

 const[employee,setEmployee]=useState({
    eid:111, ename:"abcc",  esal:9000
 });

 function updateInput(event){
    setEmployee({
        ...employee,
        [event.target.name]:event.target.value
        }
    )
 }

 function save(){
    alert(JSON.stringify(employee))
 }
    return (
        <React.Fragment>
            <p className="display-4 text-center">Contact Component</p>
            <div className="container">
                <div className="row">
                <div className="col-md-5">
                    <div className="card">
                        <div className="card-header text-center bg-primary text-white">
                            <p className="h2">Add Employee</p>
                        </div>
                        <div className="card-body">
                            <form action=""  onSubmit={save}>

                            <div className="form-group">
                                <input type="text" onChange={updateInput} name={'eid'} value={employee.eid} 
                                className="form-control"/>
                            </div>
                            <div className="form-group">
                                <input type="text" onChange={updateInput} name={'ename'} value={employee.ename} 
                                className="form-control"/>
                            </div>
                            <div className="form-group">
                                <input type="text" onChange={updateInput} name={'esal'} value={employee.esal} 
                                className="form-control"/>
                            </div>

                            <button className="btn btn-sm btn-outline-primary">Submit</button>

                            </form>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </React.Fragment>
    )
}