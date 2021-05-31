import React, { Component } from 'react'
import RatingStars from './RatingStars';
import '../Css/StarRating.css';
import '../Css/AddRestaurant.css';
import axios from 'axios';

export default class AddRestaurant extends Component {
  addRestaurantRequest = event => {


    event.preventDefault();

    let restaurantName = document.getElementById("firstForm").value;

    axios({
      method: 'post',
      url: "/api/Restaurants",
      data: {
        Authorization: 'Bearer ' + localStorage.getItem('token'),
        RestaurantName: restaurantName
      },
      
    }).then(res => { console.log(res) })
    console.log(localStorage.getItem('token'));
    


  }

    render() {
        return (
            <div>
            <div>
                <br />
                <h1 className="Header">Add a restaurant</h1>
            </div>
            <div>
                <form id="addForm">
                    <input 
                    data-cy="restaurantName"
                    id="firstForm" 
                    type="text" 
                    name="restaurant" 
                    placeholder=" Restaurant name:" />
                    <br />
                    <input 
                    id="locationForm" 
                    type="text" 
                    name="Location" 
                    placeholder=" Location:" />
                    <br />
                    <select 
                    data-cy="restaurantDescription"
                    id="firstAdd" 
                    type="text" 
                    name="Category">
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
                    
                <button 
                data-cy="submitRestaurant"
                className="submit" 
                onClick={this.addRestaurantRequest}>Submit</button>
                </form>
            </div>
            </div>
        )
    }
}
