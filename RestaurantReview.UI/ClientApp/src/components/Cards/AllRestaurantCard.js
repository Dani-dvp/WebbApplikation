import React, { Component } from "react";
import { Link } from 'react-router-dom';
import './CardsCss/AllRestaurantCards.css';
import Harold from './CardsCss/Harold.jpg';

export class AllRestaurantCard extends Component {
 
  render() {
    return (

      <div className="restCont">
        <div className="card">
        <img src={ Harold } className="card-img-top" alt="..." />
        <div className="card-body">
          <Link tag={Link} className="card-text" to={"/RestaurantPage/" + this.props.restaurantName}  >{this.props.title}</Link>
            </div>
          </div>
        </div>
    );
  }
}