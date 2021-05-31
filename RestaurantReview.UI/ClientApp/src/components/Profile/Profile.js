import React, { Component } from "react";
import Axios from "axios";

export default class Profile extends Component {

  componentDidMount = () => {
    axios({
      method: 'GET',
      url: "/api/authentication/user",
      data: {
        Authorization: 'Bearer ' + localStorage.getItem('token')
      },

    }).then(res => { console.log(res) });
    
  }
}