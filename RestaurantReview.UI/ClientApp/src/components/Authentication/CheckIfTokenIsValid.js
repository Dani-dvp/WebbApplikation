import React from 'react'
import Axios from "axios";

let loggedInStatus = "";

export  function CheckIfTokenIsValid() {
  

   Axios.get("api/Authentication/token/").then(response => { loggedInStatus = response.data })
  console.log(loggedInStatus)
  return loggedInStatus;


}