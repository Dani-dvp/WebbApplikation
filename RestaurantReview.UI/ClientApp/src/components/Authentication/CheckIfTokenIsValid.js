import React from 'react'
import Axios from "axios";

let loggedInStatus = "";

export async function CheckIfTokenIsValid(props) {


  await Axios.get("api/Authentication/token/").then(response => {
    if (response.data = true)
    {
      loggedInStatus = response.data
    }
    else
    {
      loggedInStatus = false;
    }
  })

  return loggedInStatus;


}