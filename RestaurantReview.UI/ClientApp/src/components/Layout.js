import React, { Component } from 'react';
import { Container } from 'reactstrap';
import NavMenu from './Navigation/NavMenu';
import '../Css/Layout.css';

export default class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <NavMenu/>
        
          {this.props.children}
        
      </div>
    );
  }
}
