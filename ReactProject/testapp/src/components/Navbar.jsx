import React from "react";
import {Link} from 'react-router-dom';
export default function Navbar(){
    return(
        <React.Fragment>
            <nav className="navbar navbar-dark bg-primary navbar-expand-sm">
                 
               <div className="container">
                  
                    
                    <ul className="navbar-nav"> 
                        <li className="nav-item"> <Link to="/" className="navbar-brand">Home</Link></li>


                        <li className="nav-item"> 
                            <Link to='/register' className="nav-link">Register</Link>    
                        </li>
                        <li className="nav-item"> 
                            <Link to='/login' className="nav-link">Login</Link>    
                        </li>
                        <li className="nav-item"> 
                            <Link to='/about' className="nav-link">About</Link>    
                        </li>
                        <li className="nav-item"> 
                            <Link to='/contact' className="nav-link">Contact</Link>    
                        </li>
                    </ul>
                </div>    
            </nav>
        </React.Fragment>
    )
}

//1 nav tag
// 2 container
// 3 a
// 4.