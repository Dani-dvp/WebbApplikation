import React, { Component } from 'react'
import RatingStars from './RatingStars';
import '../Css/StarRating.css';
import '../Css/AddRestaurant.css';

export class AddRestaurant extends Component {
    render() {
        return (
            <div>
            <div>
                <br />
                <h1 className="Header">Add a restaurant</h1>
            </div>
            <div>
                <form id="addForm">
                    <input id="firstForm"type="text" name="restaurant" placeholder=" Restaurant name:" />
                    <br />
                    <input id="locationForm"type="text" name="Location" placeholder=" Location:" />
                    <br />
                    <select id="firstAdd"type="text" name="Category">
                        <option value="option">Category</option>
                        <option value="food">African</option>
                        <option value="food">American</option>
                        <option value="food">British</option>
                        <option value="food">Chinese</option>
                        <option value="food">Italian</option>
                        <option value="food">Thai</option>
                        <option value="food">Indian</option>
                    </select>
                    <br />
                    <textarea id="secondForm" placeholder=" Write your review here..."></textarea>
                    <br />
                    <br />
                    <RatingStars></RatingStars>
                    <br />
                    <button className="submit"type="button">Submit</button>
                </form>
            </div>
            </div>
        )
    }
}
