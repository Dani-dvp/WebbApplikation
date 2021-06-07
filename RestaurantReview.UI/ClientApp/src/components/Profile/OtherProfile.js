import React, { Component } from 'react';
import "./Css/ProfilePage.css";
import Axios from 'axios';
import { ReviewCard } from '../Reviews/ReviewCard';

export default class ProfilePage extends Component {
  constructor(props) {
    super(props)
    this.state = {
      selectedFile: '',
      otherUser: "",
      userData: "",
      ReviewList: [],
      image: "Not Found",
      
    }

    this.handleInputChange = this.handleInputChange.bind(this);
  }
  async componentDidMount() {
    const response = await Axios.get("api/Authentication/user/" + this.props.match.params.id).then(response => {
      console.log(response)
      this.setState({
        userData: response.data,
        ReviewList: response.data.getUserByUsernameReviews,

      })
    })
      
    Axios.get("api/image/" + this.state.userData.email, { responseType: 'arraybuffer' })
          .then(data => {

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
        console.log(userAvatarData.value)
        this.setState({
          image: userAvatarData.value

        }) // here we return the base64 image data to our component

      });
   



    
   
    console.log(response)
  }

  createReviewsList() {
    let elements = [];
    for (let review of this.state.ReviewList) {
      elements.push(<ReviewCard key={review.reviewID} Rating={review.rating} restaurantName={review.restaurantName} reviewText={review.reviewText}></ReviewCard>);
    }
    return (elements);
  }

  handleInputChange(event) {
    this.setState({
      selectedFile: event.target.files[0],
    })
  }

  submit() {
    const data = new FormData()
    data.append('file', this.state.selectedFile)
     
      Axios.post("api/image", data,
      {
        params: { email: this.state.user.data.email },
      });
  }
  





  render() {


    let ListOfReviews = this.createReviewsList();
        return (
          <div>
            {/*<input type="file" className="form-control" name="upload_file" onChange={this.handleInputChange} />*/}
            {/*<button type="button" className="btn btn-dark" onClick={() => this.submit()}>Save</button>*/}
            {/*Jag tog bort möjligheten att byta ut profilbild för tillfället*/}
            <div className="profile">
                    <a id="change-pic-button" href="" aria-label="Change Profile Picture"  />
                    <div className="username">
                <h1>{this.state.userData.userName}</h1>
                    </div>
                </div>

                <form>
                    <label>
                <div
                  className="profile-pic"
                    style={{
                            backgroundImage: `url('https://bitrebels.com/wp-content/uploads/2011/02/Original-Facebook-Geek-Profile-Avatar-7.jpg')` }}>
                  <span className="glyphicon glyphicon-camera"></span>

                  <img ng-src={this.state.image} />
                  <span></span>
                        </div>
                    </label>
            </form>
            
                <div className="profile-header">
                        
                           {ListOfReviews}
                            <br />
            </div>
            
            </div>
        );
  }

  

}