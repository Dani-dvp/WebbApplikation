import React, { Component } from 'react';
import Axios from 'axios';

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
          <form id="addForm">
            <input
              data-cy="addCategoryName"
              id="categoryName"
              type="text"
              placeholder=" Category Name:" />
            <br />
            
            
            <button
              
              type="button"
              data-cy="submitAddCategory"
              className="btn btn-primary"
              onClick={() => this.addCategoryRequest()}>Add Category</button>
          </form>
        </div>
      </div>
    );
  }
}