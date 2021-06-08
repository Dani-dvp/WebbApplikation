import React, { Component } from "react";
import { Link } from 'react-router-dom';
import "./Css/Categories.css";

export class AllCategoriesCard extends Component {
 
  render() {
    return (
      
      <div className="categoriesList mt-5 mb-5 mx-auto" >
        <Link tag={Link} data-cy={ this.props.categoryName } type="button" className="ListOfCategories link-secondary" to={"/Categorypage/name/" + this.props.categoryName} > {this.props.categoryName}</Link>
          </div>
        
        
    );
  }
}