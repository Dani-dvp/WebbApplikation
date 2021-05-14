import React, { Component } from "react";
import Axios from "axios";
import "../Css/Login.css";

export default class Login extends Component {
  sendLoginRequest = (event) => {
    console.log(event);
    event.preventDefault();
    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;
    const res = Axios({
      method: 'POST',
      url: "https://localhost:44301/api/Authentication/authenticate",
      data: {
        Email: email,
        Password: password,
      },
      
    });
    console.log(res);
    
  }
  

  render() {
    return (
      <div className="wrapper">
        <div id="LoginForm">
          <h2 className="active"> Login </h2>
          <h2 className="inactive underlineHover" >Register </h2>

          <form >
            <input type="text" id="email" name="login" placeholder="Email" />
            <input
              type="text"
              id="password"
              name="password"
              placeholder="Password"
              />
            <button className="btn btn-primary" onClick={ this.sendLoginRequest }>Log in</button>
          </form>

          <form />
          <input type="button" value="Sign in with google" />

          <div id="ForgotForm">
            <a className="underlineHover" href="#">
              Forgot Password?
            </a>
          </div>
        </div>
      </div>
    );
  }
}
