import React, { Component } from "react";
import './Css/NavMenu.css';
import { Link } from 'react-router-dom'
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';


export function NavMenuLogin() {
    return (
      <header>
        <Navbar className=" navBarColor navbar-expand-sm navbar-toggleable-sm  border-bottom box-shadow mb-3 fixed-top " light>
          <Container className="ContainerWithNavbar">
            <NavbarBrand data-cy="navbarHome" tag={Link} to="/">Home</NavbarBrand>
            <NavbarToggler className="mr-2" />
            <Collapse className="d-sm-inline-flex flex-sm-row-reverse"  navbar>
              <ul className="navbar-nav flex-grow navbar-right">
                <NavItem>
                  <NavLink
                    data-cy="navbarCategories"
                    tag={Link}
                    className="navBarColor"
                    to="/profile/">Profile</NavLink>
                </NavItem>
                <div>
                  <NavItem><NavLink
                    data-cy="navbarLogin"
                    tag={Link}
                    className="navBarColor"
                    to="/login">Login</NavLink></NavItem>
                </div>
              </ul>
            </Collapse>
          </Container>
        </Navbar>
      </header>
    )
    
  
}