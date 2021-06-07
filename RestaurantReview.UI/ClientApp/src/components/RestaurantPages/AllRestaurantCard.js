import React, { Component } from "react";
import { Link } from 'react-router-dom';
import './Css/AllRestaurantCards.css';
import Harold from '../Harold.jpg';

export class AllRestaurantCard extends Component {
 
  render() {
    return (
      <div className="restCont">
        <div className="card" style={{ background: "#a73003", color: "f9e7d9" }}>
          <img src={this.props.TempImage} className="card-img-top" alt="..." />
          <div className="card-body" style={{ background: "#a73003", color: "f9e7d9"  }}>
            <Link tag={Link} style={{ color: "f9e7d9" }}  to={"/RestaurantPage/" + this.props.restaurantName}  >{this.props.title}</Link>
            </div>
          </div>
        </div>
    );
  }
}