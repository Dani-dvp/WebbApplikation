import React, { Component } from "react";
import Axios from "axios";
import { Link } from 'react-router-dom';
import { Redirect } from "react-router-dom"; 
import "./Css/Login.css";


export default class Login extends Component {
  constructor(props) {
    super(props);
    this.state = {
      loggedIn: this.props.loggedIn
    }

    this.handleSuccessfulAuth = this.handleSuccessfulAuth.bind(this);
    this.handleFailedAuth = this.handleFailedAuth.bind(this);
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

    }).then(res => {
      if (res.status === 200) {
        this.handleSuccessfulAuth(res)
        
      }
      else
      {
        this.handleFailedAuth()
      }
    })
    
  }

  handleSuccessfulAuth(data) {
    this.props.handleLogin(data);
    this.props.history.push("/");
    localStorage.setItem('token', data.data.token)
    Axios.defaults.headers.common['Authorization'] = 'Bearer ' + localStorage.getItem('token')

  }

  handleFailedAuth() {
    localStorage.clear();
    delete Axios.defaults.headers.common['Authorization'];

    this.props.handleFailedLogin()

  }


  

  render() {
    const isLoggedIn = this.state.loggedIn;
    let button;
    if (isLoggedIn) {
      button = <button onClick={this.handleFailedAuth} >Logout</button>;
    } else {
      button = <button onClick={this.sendLoginRequest} >Login</button>;
    }
     
    
    return (
      <div className="wrapper">
        <div id="LoginForm">
          <h2 className="active"> Login </h2>
          <Link
            data-cy="register"
            to="/register"
            className="inactive underlineHover"><h2>Register</h2></Link>

          <form>
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
              type="button"
              data-cy="submitLogin"
              className="btn btn-primary"
              onClick={this.sendLoginRequest}>Log in</button>
            <br />




            <button
              type="button"
              data-cy="checkOnLoginPage"
              className="btn btn-primary"
              onClick={() => {
                this.setState({
                  loggedIn: this.handleFailedAuth()
                });
              }}>Logout</button>

          </form>



        </div>
      </div>

    );
  }


}
