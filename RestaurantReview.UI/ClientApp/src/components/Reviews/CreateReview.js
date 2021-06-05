import React, { Component } from 'react'
import { Link } from 'react-router-dom';
import Star from './Star';
import RatingStars from './RatingStars';
import axios from 'axios';
import '../RestaurantPages/Css/StarRating.css';
import './Css/CreateReview.css';

export default class CreateReview extends Component {
  constructor(props) {
    super(props)
    this.state = {
      user: this.props.user,
      rating: 0,
      
    }
  }



  AddReviewRequest = event => {
    event.preventDefault();
    
    let reviewText = document.getElementById("secondForm").value;

    axios({
      method: 'post',
      url: "/api/review",
      data: {
        restaurantName: this.props.match.params.id,
        ReviewText: reviewText,
        Rating: this.state.rating,
        ApplicationUserId: this.state.user.data.id,
      },

    }).then(res => { console.log(res) });
  }




    render() {
        return (
            <div className="surroundingDiv">
            <div>
                <br />
                <h1 className="Header">Share your own experience</h1>
            </div>
            <div>
                <form id="reviewForm">
                <h3>{this.props.match.params.id}</h3>
                    <br />
                    <textarea 
                    data-cy="reviewText"
                    id="secondForm" 
                    placeholder=" Write your review here..."></textarea>
                    <br />
                <RatingStars className="stars" onClick={() => this.setState({ rating: this.state.rating + 1 })}></RatingStars>
                    <br />
                <button 
                data-cy="submitReview"
                  className="homeButton btn btn-info btn-lg" 
                onClick={this.AddReviewRequest}>Submit</button>
                </form>
            </div>

            </div>
        );
    }
}
