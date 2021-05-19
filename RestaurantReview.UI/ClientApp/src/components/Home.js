import React, { Component } from 'react';
import '../Css/Home.css';

export default class Home extends Component {
  static displayName = Home.name;


  
  render () {
    return (
      <div>
        <section id="showcase">
          <div>
            <form id="location">
              <input
                id="loc1"
                type="text"
                name="loc"
                placeholder="Location:" />
              <input
                id="loc2"
                type="text"
                name="rest"
                placeholder="Restaurant:" />
            </form>
          </div>
        </section>
      </div>
    );
  }
}
