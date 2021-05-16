import React, { Component } from 'react'
import { Link } from 'react-router-dom';
import RatingStars from './RatingStars';
import '../Css/StarRating.css';
import '../Css/CreateReview.css';

export default class CreateReview extends Component {
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
                    <button className="submit">Submit</button>
                </form>
            </div>

            <div>
                <p id="reviewText">Is your restaurant not here?</p>
                <form >
                    <button><Link activeClassName="Active" to="/addrestaurant">Add A Restaurant!</Link></button>
                </form>
            </div>
            </div>
        );
    }
}
