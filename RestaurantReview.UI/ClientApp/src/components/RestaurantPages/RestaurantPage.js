import React, { Component } from "react";
import axios from "axios";
import RestaurantPageCard from "./RestaurantPageCard";
import { ReviewCard } from "../Reviews/ReviewCard";
import { Link } from 'react-router-dom';
import "./Css/RestaurantPage.css";

export default class RestaurantPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      restaurant: {},
      reviews: []
    };
  }

  
    
    async componentDidMount() {
      const response = await axios.get("api/v1/Restaurants/name/" + this.props.match.params.id);

      this.setState({
        restaurant: response.data,
        reviews: response.data.reviewsDtoResponse
      });
      console.log(this.state.reviews);
    }
  

  render() {
    let thisRestaurant = this.createThisRestaurant();
    let ListOfReviews = this.createReviewsList();
    
    return (
      <div className="Trying">
        <div>
        {thisRestaurant}
          <Link tag={Link} className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }} to={"/createreview/" + this.state.restaurant.restaurantName}>Add your own review here!</Link>
        
          
        </div>
        <br />
        { ListOfReviews}
        <br />
        
      </div>
    );
  }



  createThisRestaurant() {
    let element = <RestaurantPageCard TempImage={ this.state.restaurant.tempImage }restaurantName={this.state.restaurant.restaurantName} description={this.state.restaurant.description} website={ this.state.restaurant.restaurantLink } ></RestaurantPageCard>;

    
    return (element);
  }




  createReviewsList() {
    let elements = [];
    for (let review of this.state.reviews) {
      elements.push(<ReviewCard userName={review.userName } key={review.reviewID} Rating={review.rating} reviewText={review.reviewText}></ReviewCard>);
    }
    return (elements);
  }
  
}
