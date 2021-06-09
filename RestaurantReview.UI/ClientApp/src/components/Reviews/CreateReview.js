import React, { Component } from 'react'
import { Link } from 'react-router-dom';
import axios from 'axios';
import ReactDOM from 'react-dom';
import StarRatingComponent from 'react-star-rating-component';
import '../RestaurantPages/Css/StarRating.css';
import './Css/CreateReview.css';

export default class CreateReview extends Component {
  constructor(props) {
    super(props)
    this.state = {
      rating: 1,
    }
  }

  onStarClick(nextValue, prevValue, name) {
    this.setState({ rating: nextValue });
  }

  AddReviewRequest = event => {
    event.preventDefault();
 
    let reviewText = document.getElementById("reviewText").value;

    axios({
      method: 'post',
      url: "/api/v1/review",
      data: {
        restaurantName: this.props.match.params.id,
        ReviewText: reviewText,
        Rating: this.state.rating,
        ApplicationUserId: this.props.user.data.id,
      },

    }).then(res => { console.log(res) });
  }




    render() {
      const { rating } = this.state;
        return (
            <div className="surroundingDiv ">
            <div>
                <br />
                <h1 className="Header">Share your own experience</h1>
            </div>
            <div>
                <form className="addForm mx-auto d-block">
                <h3>{this.props.match.params.id}</h3>
                    <br />
                <textarea 
                  id="reviewText"
                    data-cy="reviewText"
                    placeholder=" Write your review here..."></textarea>
                    <br />
                <h2 className="text-dark">Rating: {rating}</h2>
                <div>
                <StarRatingComponent
                  data-cy="ratingStars"
                    className="display-4"
                  name="rate1"
                  starCount={5}
                  value={rating}
                  onStarClick={this.onStarClick.bind(this)}
                  />
                  </div>
                    <br />
                <button 
                data-cy="submitReview"
                  className="homeButton btn  btn-lg btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }} 
                onClick={this.AddReviewRequest}>Submit</button>
                </form>
            </div>

            </div>
        );
    }
}
