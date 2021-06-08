import React, { Component } from 'react';
import Axios from 'axios';
import './Css/Categories.css';

export default class AddCategory extends Component {
  constructor(props) {
    super(props)
  }



  addCategoryRequest() {
    let categoryName = document.getElementById("categoryName").value;
    Axios({
      method: 'post',
      url: "/api/v1/categories",
      data: {
        CategoryName: categoryName

      },

    }).then(res => {
      if (res.status === 200) {
        this.props.history.push("/categories");
      }
    })
  }
  


  render() {
    return (
      <div>
        <div>
          <br />
          <h1 className="Header">Add a Category</h1>
        </div>
        <div>
          <br />
          <br />
          <form className="addForm mx-auto d-block">
            <input
              data-cy="addCategoryName"
              id="categoryName"
              type="text"
              placeholder=" Category Name:" />
            <br />
            <br />
            
            <button
              type="button"
              data-cy="submitAddRestaurant"
              className="homeButton btn  btn-lg btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
              onClick={() => this.addCategoryRequest()}>Add Category</button>
          </form>
        </div>
      </div>
    );
  }
}