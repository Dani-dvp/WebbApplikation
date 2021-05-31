import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import '../Css/NavMenu.css';

export default class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render() {
    const isLoggedIn = this.state.isLoggedIn;
    return (
      <header>
        <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3 fixed-top bg-white" light>
          <Container className="ContainerWithNavbar">
            <NavbarBrand data-cy="navbarHome"tag={Link} to="/">Home</NavbarBrand>
            <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
            <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
              <ul className="navbar-nav flex-grow navbar-right">
                <NavItem>
                  <NavLink 
                  data-cy="navbarCategories"
                  tag={Link} 
                  className="text-dark" 
                  to="/categories">Categories</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink 
                  data-cy="navbarReview"
                  tag={Link} 
                  className="text-dark" 
                  to="/createreview">Create A Review</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink 
                    data-cy="navbarLogin"
                    tag={Link} 
                    className="text-dark" 
                    to="/login">Login</NavLink>
                </NavItem>
              </ul>
            </Collapse>
          </Container>
        </Navbar>
      </header>
    );
  }
}
