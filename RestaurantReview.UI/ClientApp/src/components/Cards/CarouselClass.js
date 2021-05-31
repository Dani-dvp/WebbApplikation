import React, { Component } from 'react';
import Harold from './CardsCss/Harold.jpg';
import Carousel from 'react-bootstrap/Carousel';
import './CardsCss/CarouselClass.css';

export default class CarouselClass extends Component {

  render() {
    return (

      <Carousel className="carouselHome d-inline-block d-block">
        <Carousel.Item>
          <img
           data-cy ="carouselHomeImage1"
            className="d-block "
            src={Harold}
            alt="First slide"
          />
          <Carousel.Caption>
            <h3>First slide label</h3>
            <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
          </Carousel.Caption>
        </Carousel.Item>
        <Carousel.Item>
          <img
           data-cy ="carouselHomeImage2"
            className="d-block  "
            src={ Harold }
            alt="Second slide"
          />

          <Carousel.Caption>
            <h3>Second slide label</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
          </Carousel.Caption>
        </Carousel.Item>
        <Carousel.Item>
          <img
           data-cy ="carouselHomeImage3"
            className="d-block "
            src={Harold}
            alt="Third slide"
          />

          <Carousel.Caption>
            <h3>Third slide label</h3>
            <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur.</p>
          </Carousel.Caption>
        </Carousel.Item>

      </Carousel>
      );
  }
}