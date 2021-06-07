import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './Css/NavMenu.css';
import { NavMenuLogin }  from './NavMenuLogin'
import { NavMenuLogout }  from './NavMenuLogout'

export default class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor(props) {
    super(props);

    this.state = {
      collapsed: true,
      user: this.props.user,
      isLoggedIn: this.props.loggedIn,
    };

    
  }

  render() {
    return !this.state.isLoggedIn ? (
      <div>
        <NavMenuLogin />
      </div>
    ) : (
        <div>
          <NavMenuLogout />
        </div>
      );
  }
   LogoutButton(props) {
  return (
    <NavItem><NavLink
      onClick={props.onClick}
      data-cy="navbarLogin"
      tag={Link}
      className="text-dark"
      to="/login">Logout</NavLink></NavItem>
  );
  }
  LoginButton(props) {
    return (
      <NavItem><NavLink
        onClick={props.onClick}
        data-cy="navbarLogin"
        tag={Link}
        className="text-dark"
        to="/login">Login</NavLink></NavItem>
    );
  }
}
