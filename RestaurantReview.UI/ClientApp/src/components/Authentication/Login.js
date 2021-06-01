import React, { Component } from "react";
import Axios from "axios";
import { Link } from 'react-router-dom';
import { Redirect } from "react-router-dom"; 
import "./Css/Login.css";
import { CheckIfTokenIsValid } from './CheckIfTokenIsValid';

export default class Login extends Component {
  constructor(props) {
    super(props);
    this.state = {
      loggedIn: false,
    }
  }


  sendLoginRequest = event => {

    
    event.preventDefault();

    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;

    Axios({
      method: 'post',
      url: "/api/Authentication/login",
      data: {
        Email: email,
        Password: password,
      },

    }).then(res => { localStorage.setItem('token', res.data.token) });
    
    console.log(localStorage.getItem('token'));
  }
  
  logOutRequest = event => {
    event.preventDefault();
    console.log(localStorage.getItem('token'));
    localStorage.clear();
    delete Axios.defaults.headers.common['Authorization'];
    console.log(localStorage.getItem('token'));
  }



  

  render() {
    return (
      <div className="wrapper">
        <div id="LoginForm">
          <h2 className="active"> Login </h2>
          <Link 
          data-cy="register"
          to="/register" 
          className="inactive underlineHover"><h2>Register</h2></Link>

          <form >
            <input
            data-cy="loginEmail"
              type="text"
              id="email"
              name="login"
              placeholder="Email" />
            <input
            data-cy="loginPassword"
              type="text"
              id="password"
              name="password"
              placeholder="Password"
              />
            <button 
            data-cy="submitLogin"
            className="btn btn-primary" 
            onClick={this.sendLoginRequest}>Log in</button>
            <br />
            <button 
            data-cy="checkOnLoginPage"
            className="btn btn-primary" 
            onClick={this.logOutRequest}>Log out</button>
            <button
              type="button"
              className="btn btn-primary"
              onClick={() => {
                this.setState({
                  loggedIn: CheckIfTokenIsValid()
                });
              }}>Check</button>

            
            <button
              type="button"
              className="btn btn-primary"
              onClick={console.log(this.state.loggedIn)}>print</button>
          </form>

          <form />

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
