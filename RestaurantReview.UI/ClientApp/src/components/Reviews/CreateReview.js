import React, { Component } from 'react'
import { Link } from 'react-router-dom';
import RatingStars from './RatingStars';
import axios from 'axios';
import '../RestaurantPages/Css/StarRating.css';
import './Css/CreateReview.css';

export default class CreateReview extends Component {
  constructor(props) {
    super(props)
    this.state = {
      user: this.props.user,
      
    }
  }



  AddReviewRequest = event => {
    event.preventDefault();
    console.log(this.state.user.data.id)

    let restaurantName = document.getElementById("firstForm").value;
    let reviewText = document.getElementById("secondForm").value;

    axios({
      method: 'POST',
      url: "/api/review",
      data: {
        RestaurantName: restaurantName,
        ReviewText: reviewText,
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
                    <input 
                    data-cy="reviewRestaurantName"
                    id="firstForm"
                    type="text" 
                    name="restaurant" 
                    placeholder=" Restaurant name:" />
                    <br />
                    <textarea 
                    data-cy="reviewText"
                    id="secondForm" 
                    placeholder=" Write your review here..."></textarea>
                    <br />
                    <RatingStars className="stars"></RatingStars>
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
