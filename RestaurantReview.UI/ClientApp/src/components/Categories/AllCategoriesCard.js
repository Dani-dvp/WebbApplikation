import React, { Component } from "react";
import { Link } from 'react-router-dom';
import "./Css/Categories.css";

export class AllCategoriesCard extends Component {
 
  render() {
    return (
      
      <div>
        <Link tag={Link} type="button" className="ListOfCategories link-secondary" to={"/Categorypage/name/" + this.props.categoryName} > {this.props.categoryName}</Link>
          </div>
        
        
    );
  }
}