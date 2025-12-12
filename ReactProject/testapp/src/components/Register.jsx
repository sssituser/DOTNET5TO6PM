import React,{useState} from "react";
export default function Register(){
    const[count,setCount]=useState(0);
    function increment(){
        setCount(count+1)
    }
    function decrement(){
        setCount(count-1>0 ? count-1:1)
    }
    return (
        <React.Fragment>
            <p className="display-4 text-center">Register Component</p>
            <div className="container text-center">
                <p className="h1">Count is : {count}</p>
                <button className="btn btn-md btn-success" onClick={increment}>Increase</button>
                <button className="btn btn-md btn-danger" onClick={decrement}>Decrease</button>
            </div>
        </React.Fragment>
    )
}