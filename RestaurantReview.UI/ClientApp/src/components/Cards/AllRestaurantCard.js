import React, { Component } from "react";
import { Link } from 'react-router-dom';

export class AllRestaurantCard extends Component {
 
  render() {
    return (
      
      <div className="card" rows="4">
        <img src="..." className="card-img-top" alt="..." />
        <div className="card-body">
          <Link tag={Link} className="card-text" to={"/RestaurantPage/" + this.props.restaurantName}  >{this.props.title}</Link>
            
          </div>
        </div>
        
    );
  }
}