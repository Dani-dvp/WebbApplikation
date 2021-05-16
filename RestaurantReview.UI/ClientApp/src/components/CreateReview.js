import React, { Component } from 'react'
import { Link } from 'react-router-dom';
import RatingStars from './RatingStars';
import axios from 'axios';
import '../Css/StarRating.css';
import '../Css/CreateReview.css';

export default class CreateReview extends Component {
  AddReviewRequest = event => {
    event.preventDefault();

    let restaurantName = document.getElementById("firstForm").value;
    let reviewText = document.getElementById("secondForm").value;

    axios({
      method: 'POST',
      url: "/api/review",
      data: {
        RestaurantName: restaurantName,
        ReviewText: reviewText,
        Authorization: 'Bearer ' + localStorage.getItem('token')
      },

    }).then(res => { console.log(res) });
  }




    render() {
        return (
            <div>
            <div>
                <br />
                <h1 className="Header">Share your own experience</h1>
            </div>
            <div>
                <form id="reviewForm">
                    <input id="firstForm"type="text" name="restaurant" placeholder=" Restaurant name:" />
                    <br />
                    <textarea id="secondForm" placeholder=" Write your review here..."></textarea>
                    <br />
                    <RatingStars></RatingStars>
                    <br />
                <button className="submit" onClick={this.AddReviewRequest}>Submit</button>
                </form>
            </div>

            <div>
                <p id="reviewText">Is your restaurant not here?</p>
                <form >
                    <button><Link className="Active" to="/addrestaurant">Add A Restaurant!</Link></button>
                </form>
            </div>
            </div>
        );
    }
}
