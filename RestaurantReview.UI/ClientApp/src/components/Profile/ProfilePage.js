import React, { Component } from 'react';
import "./Css/ProfilePage.css";
import Axios from 'axios';
import { ReviewCard } from '../Reviews/ReviewCard';

export default class ProfilePage extends Component {
  constructor(props) {
    super(props)
    this.state = {
      selectedFile: '',
      user: this.props.user,
      userData: "",
      ReviewList: []
    }

    this.handleInputChange = this.handleInputChange.bind(this);
  }
  async componentDidMount() {
    const response = await Axios.get("api/Authentication/user/" + this.props.user.data.userName);

    this.setState({
      userData: response.data,
      ReviewList: response.data.getUserByUsernameReviews
    })

    console.log(this.state.ReviewList)
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
    console.warn(this.state.selectedFile);
    console.log(this.state.user.data)


    
      Axios.post("api/image", data,
      {
        params: { email: this.state.user.data.email },
      });

  }

  render() {
    let ListOfReviews = this.createReviewsList();
        return (
            <div>
                <div className="profile">
                    <a id="change-pic-button" href="" aria-label="Change Profile Picture"  />
                    <div className="username">
                <p>{this.state.userData.userName}</p>
                    </div>
                </div>

                <form>
                    <label>
                <input type="file" className="form-control" name="upload_file" onChange={this.handleInputChange} />
                <button type="button" className="btn btn-dark" onClick={() => this.submit()}>Save</button>
                <div
                  className="profile-pic"
                    style={{
                            backgroundImage: `url('https://bitrebels.com/wp-content/uploads/2011/02/Original-Facebook-Geek-Profile-Avatar-7.jpg')` }}>
                  <span className="glyphicon glyphicon-camera"></span>
                  <span></span>
                  <img src={`/uploads/${this.state.userData.getUserImageResponse}`}/>
                        </div>
                    </label>
            </form>
            
                <div className="profile-header">
                </div>
                <div className="profile-body">
                    <div className="profile-posts">
                        <h5>Reviews</h5>
                        <div className="reviewposts">
                           {ListOfReviews}
                            
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}