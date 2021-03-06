import React, { Component } from 'react';
import CarouselClass from './Cards/CarouselClass';
import { Link } from 'react-router-dom';
import '../Css/Home.css';
import FileUpload from './FileUpload/FileUpload';

export default class Home extends Component {
  static displayName = Home.name;
  constructor(props) {
    super(props)
  }
  
  
  render () {
    return (
      <div className="mx-auto d-block mb-4">
        <CarouselClass type="button" className="homeCarousel"></CarouselClass>
        <br />
        <div className="mx-auto">
          <Link data-cy="homeRestaurantsBtn" tag={Link} className="homeButton btn  btn-lg btn-danger" style={{background: "#a73003", color: "#f9e7d9"}}to={"/restaurants"}>All Restaurants</Link>
          <Link data-cy="homeCategoriesBtn" tag={Link} className="homeButton btn  btn-lg btn-danger" style={{ background: "#a73003", color: "#f9e7d9"}} to={"/categories"}>Categories</Link>

          
        </div>
      </div>
    );
  }
}
