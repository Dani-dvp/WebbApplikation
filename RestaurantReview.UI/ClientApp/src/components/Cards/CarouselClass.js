import React, { Component } from 'react';
import Axios from 'axios';
import { Link } from 'react-router-dom';
import Carousel from 'react-bootstrap/Carousel';
import './Css/CarouselClass.css';

export default class CarouselClass extends Component {
  constructor() {
    super();
    this.state = {
      restaurants: [],
      loading: true
    }
  }

  async componentDidMount() {

    const response = await Axios.get("api/v1/restaurants/random");
    this.setState({
      restaurants: response.data,
      loading: false
    });

  }

  createCarousel() {
    return (
      <Carousel className="carouselHome d-inline-block d-block shadow-lg ">
        <Carousel.Item>
          <a type="button" href={"/RestaurantPage/" + this.state.restaurants[0].restaurantName}>
            <img 
              
          data-cy="carouselHomeImage1"
              className="d-block"
          src={this.state.restaurants[0].tempImage}
          alt="First slide"
            />
            </a>
        <Carousel.Caption>
            <h3>{this.state.restaurants[0].restaurantName}</h3>
        </Carousel.Caption>
      </Carousel.Item>
        <Carousel.Item>
          <a type="button" href={"/RestaurantPage/" + this.state.restaurants[1].restaurantName}>
            <img
          data-cy="carouselHomeImage2"
              className="d-block "
            src={this.state.restaurants[1].tempImage}
          alt="Second slide"
        />
            </a>
        <Carousel.Caption>
            <h3>{this.state.restaurants[1].restaurantName}</h3>
        </Carousel.Caption>
      </Carousel.Item>
        <Carousel.Item>
          <a type="button" href={"/RestaurantPage/" + this.state.restaurants[2].restaurantName}>
            <img
          data-cy="carouselHomeImage3"
              className="d-block "
            src={this.state.restaurants[2].tempImage}
          alt="Third slide"
            />
            </a>

        <Carousel.Caption>
            <h3 >{this.state.restaurants[2].restaurantName}</h3>
        </Carousel.Caption>
      </Carousel.Item>

      </Carousel>
    )
  }
  render() {
    let content = this.state.loading ? <p>Loading...</p> : this.createCarousel()
    return (
      <div>
        {content}
        </div>
  );

  }
}