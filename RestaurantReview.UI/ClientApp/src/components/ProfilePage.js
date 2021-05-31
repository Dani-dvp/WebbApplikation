import React, { Component } from 'react';
import "../Css/ProfilePage.css";

export default class ProfilePage extends Component {

    /* UploadPicture() {
 
         var fd = new FormData();
         var files = ('#file')[0].files;
 
         // Check file selected or not
         if (files.length > 0) {
             fd.append('file', files[0]);
 
                 ajax({
                 url: 'upload.php',
                 type: 'post',
                 data: fd,
                 contentType: false,
                 processData: false,
                 success: function (response) {
                     alert("Your image was uploaded");
                 },
                 error: function (response) {
                     alert("Your image could not be uploaded");
                 }
             });
         }
     }
     */
    render() {
        return (
            <div>
                <div className="profile">
                    <a id="change-pic-button" href="" aria-label="Change Profile Picture" />
                    <div className="username">
                        <p>Username</p>
                    </div>
                </div>

                <form>
                    <label>
                        <input type="file" id="file" />
                        <div className="profile-pic" style={{
                            backgroundImage: `url('https://bitrebels.com/wp-content/uploads/2011/02/Original-Facebook-Geek-Profile-Avatar-7.jpg')` }}>
                            <span className="glyphicon glyphicon-camera"></span>
                            <span>Change Image</span>
                        </div>
                    </label>
                </form>

                <div className="profile-header">
                </div>
                <div className="profile-body">
                    <div className="profile-posts">
                        <h5>Reviews</h5>
                        <div className="reviewposts">
                            fjfdsifjdsik
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}