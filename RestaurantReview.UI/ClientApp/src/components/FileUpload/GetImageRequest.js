import React, { Component } from 'react';
import Axios from 'axios';


export async function getImageData(email) {
  await Axios.get("api/v1/image/" + email, { responseType: 'arraybuffer' }).then((data) => {
    
    const b64Data = btoa(
      new Uint8Array(data.data).reduce(
        (dataArray, byte) => {
          return dataArray + String.fromCharCode(byte);
        },
        
      )
    );
    const userAvatarData = {
      key: 'userAvatar',
      value: `data:image/png;base64,${b64Data}`

    };
    console.log(userAvatarData.value);
    return userAvatarData.value; // here we return the base64 image data to our component

  });
}