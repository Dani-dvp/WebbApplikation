import React, { Component } from 'react'
import '../Css/CreateReview.css';
import { Link } from 'react-router-dom';

export class CreateReview extends Component {
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
                    <button className="button"type="button" /><img src="../Images/Star.png" alt="Here we go" />
                    <button className="button"type="button" /><img src="../images/Star.png" alt="Here we go" />
                    <button className="button"type="button" /><img src="../images/Star.png" alt="Here we go" />
                    <button className="button"type="button" /><img src="../images/Star.png" alt="Here we go" />
                    <button className="button"type="button" /><img src="../images/Star.png" alt="Here we go" />
                    <br />
                    <button class="submit"type="button">Submit</button>
                </form>
            </div>

            <div>
                <p id="reviewText">Is your restaurant not here?</p>
                <form>
                    <button id="reviewButton"type="button" /><Link to="/addrestaurant">Add A Restaurant!</Link>
                </form>
            </div>
            </div>
        );
    }
}
