import React, { Component } from 'react';
import './Css/ReviewCard.css';
import { Link } from 'react-router-dom';


export class ReviewCard extends Component {

  render() {
    return (
      <div className="card reviewCard mb-2" style={{ color: "#f9e7d9" }} >
        <div className="" style={{color: "#f9e7d9"}}>
          <h2> {this.props.reviewText} </h2>
          <Link tag={Link} className="display-7" to={"/RestaurantPage/" + this.props.restaurantName} style={{ color: "#f9e7d9" }}> {this.props.restaurantName}</Link>
          <Link tag={Link} className="display-7" to={"/otherprofile/" + this.props.userName} style={{ color: "#f9e7d9" }}> {this.props.userName}</Link>
          <footer className="display-5" style={{ color: "#f9e7d9" }}> - {this.props.Rating} / 5</footer>
          </div>
      </div>
      );
  }

}