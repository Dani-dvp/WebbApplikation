import React, { Component } from "react";
import "./Css/Register.css";
import { Link } from 'react-router-dom';
import axios from 'axios';


export default class Register extends Component {

  sendRegisterRequest = event => {
    event.preventDefault()

    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;
    let userName = document.getElementById("userName").value;
    //let confirm = document.getElementById("passwordConfirm_input");

    axios({
      method: 'POST',
      url: "/api/Authentication/register",
      data: {
        Email: email,
        Password: password,
        UserName: userName,
        FirstName: "",
        LastName: ""
      },

    }).then(res => { console.log(res) });

  }

//  validatePassword = () => {
//  if (password.value != confirm.value) {
//    confirm.setCustomValidity("Passwords does not match");
//  } else {
//    confirm.setCustomValidity('');
//  }
//  confirm.reportValidity();
//}




  render() {
    return (
      <div className="wrapper">
        <div id="RegisterForm">
       
          <Link to="/login" className="inactive underlineHover"><h2>Login</h2></Link>
          <h2 className="active">Register </h2>

         
        <form action="/action_page.php" method="post">
            
            <input 
            data-cy="registerUsername"
            type="text" 
            name="userName" 
            id="userName" 
            placeholder="Username" 
            required />
            
            <input 
            data-cy="registerEmail"
            type="email" 
            name="email" 
            id="email" 
            placeholder="Email" 
            required />

           
            <input 
            data-cy="registerPassword"
            type="password" 
            name="password" 
            id="password" 
            placeholder="Password" 
            required />

            
            <input 
            data-cy="registerConfirmPassword"
            type="password" 
            name="passwordConfirm_input" 
            id="passwordConfirm_input" 
            placeholder="Confirm Password" required />



            <div>
              <p>By clicking on register you agree on our <a href="#">terms and conditions</a>.</p>
            </div>
            <button 
            data-cy="submitRegistration"
            className="btn btn-primary" 
            onClick={this.sendRegisterRequest}>Log in</button>

        </form>
      </div>
        </div>
      )
  }
  }




