import React, { Component } from 'react';
import Axios from 'axios';

export default class AdminPage extends Component {
  constructor(props) {
    super(props)
    this.state = {
      
    }
  }
  deleteRestaurant() {
    let deleteRestaurantName = document.getElementById("deleteRestaurantName").value;
    Axios({
      method: 'delete',
      url: "/api/v1/restaurants",
      data: {
        Restaurantname: deleteRestaurantName
      },
    })
  }

  updateRestaurant() {
    let updateRestaurantName = document.getElementById("updateRestaurantName").value;
    let updateRestaurantPicture = document.getElementById("updateRestaurantPicture").value;
    let updateRestaurantWebsite = document.getElementById("updateRestaurantWebsite").value;
    let updateRestaurantDescription = document.getElementById("updateRestaurantDescription").value;
    
    Axios({
      method: 'put',
      url: "/api/v1/restaurants",
      data: {
        Restaurantname: updateRestaurantName,
        TempImage: updateRestaurantPicture,
        RestaurantLink: updateRestaurantWebsite,
        Description: updateRestaurantDescription
      },
    })
  }

  deleteReview() {
    let deleteReviewId = document.getElementById("deleteReviewId").value;
    Axios({
      method: 'delete',
      url: "/api/v1/review",
      data: {
        ReviewID: deleteReviewId
      },
    })
  }

  updateReview() {
    let updateReviewId = document.getElementById("updateReviewId").value;
    let updateReviewText = document.getElementById("updateReviewText").value;
    let updateReviewRating = document.getElementById("updateReviewRating").value;

    Axios({
      method: 'put',
      url: "/api/v1/review",
      data: {
        ReviewID: updateReviewId,
        ReviewText: updateReviewText,
        Rating: updateReviewRating
      },
    })
  }

  AddCategoryToRestaurant() {
    let AddCategoryToRestaurantName = document.getElementById("AddCategoryToRestaurantName").value;
    let AddRestaurantToCategoryName = document.getElementById("AddRestaurantToCategoryName").value;
    Axios({
      method: 'post',
      url: "/api/v1/restaurants/addCategory",
      data: {
        CategoryName: AddCategoryToRestaurantName,
        RestaurantName: AddRestaurantToCategoryName
      },
    }).then(res => {
      if (res.status === 200) {
        Axios({
          method: 'post',
          url: "/api/v1/categories/addRestaurant",
          data: {
            CategoryName: AddCategoryToRestaurantName,
            RestaurantName: AddRestaurantToCategoryName
          },
        })
      }
    })
  }

  deleteUser() {
    let deleteUsername = document.getElementById("deleteUsername").value;
    Axios({
      method: 'delete',
      url: "/api/v1/authentication/user",
      data: {
        Username: deleteUsername
      },
    })
  }

  deleteCategory() {
    let deleteCategory = document.getElementById("deleteCategory").value;
    Axios({
      method: 'delete',
      url: "/api/v1/categories/",
      data: {
        CategoryName: deleteCategory
      },
    })
  }

  render() {


    return (

      <div>

        <h3>Restaurants</h3>
        <h5>Delete Restaurant</h5>
        <form id="deleteRestaurantForm">
          <input
            id="deleteRestaurantName"
            data-cy="deleteRestaurantForm"
            type="text"
            placeholder="Delete restaurant by name:" />
          <br />
        <button
          type="button"
          data-cy="deleteRestaurantButton"
            className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
            onClick={() => this.deleteRestaurant()}>Delete Restaurant</button>
        </form>

        <h5>Update Restaurant</h5>
        <form id="updateRestaurantForm">

        <input
            data-cy="updateRestaurantName"
            id="updateRestaurantName"
          type="text"
            placeholder="Update restaurant by name:" />

            <input
              data-cy="updateRestaurantPicture"
            id="updateRestaurantPicture"
              type="text"
            placeholder="Update Restaurant Picture:" />

              <input
                data-cy="updateRestaurantWebsite"
                id="updateRestaurantWebsite"
                type="text"
            placeholder="Update Restaurant Website:" />
          <input
            data-cy="updateRestaurantDescription"
            id="updateRestaurantDescription"
            type="text"
            placeholder="Update Restaurant Description: " />

        <br />
        <button
          type="button"
            data-cy="updateRestaurantButton"
            className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
            onClick={() => this.updateRestaurant()}>Update Restaurant</button>
          </form>
      
        <h3>Reviews</h3>
        <h5>Delete Review</h5>
        <form id="deleteReviewForm">
          <input
            id="deleteReviewId"
            data-cy="deleteReviewId"
            type="text"
            placeholder="Delete review by Id:" />
          <br />
          <button
            type="button"
            data-cy="deleteReviewButton"
            className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
            onClick={() => this.deleteReview()}>Delete Review</button>
        </form>

        <h5>Update Review</h5>
        <form id="updateReviewForm">

          <input
            data-cy="updateReviewId"
            id="updateReviewId"
            type="text"
            placeholder="Insert review ID to be updated:" />

          <input
            data-cy="updateReviewText"
            id="updateReviewText"
            type="text"
            placeholder="Update Review text:" />

          <input
            data-cy="updateReviewRating"
            id="updateReviewRating"
            type="text"
            placeholder="Update Review Rating:" />

          <br />
          <button
            type="button"
            data-cy="updateReviewButton"
            className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
            onClick={() => this.updateReview()}>Update Review</button>
        </form>

        <h3>Categories</h3>
        <h5>Add Category To Restaurant</h5>
        <form id="AddCategoryToRestaurantForm">

          <input
            data-cy="AddRestaurantToCategoryName"
            id="AddRestaurantToCategoryName"
            type="text"
            placeholder="Restaurant name:" />

          <input
            data-cy="AddCategoryToRestaurantName"
            id="AddCategoryToRestaurantName"
            type="text"
            placeholder="Category name:" />

          <br />
          <button
            type="button"
            data-cy="AddCategoryToRestaurantButton"
            className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
            onClick={() => this.AddCategoryToRestaurant()}>Add Category to Restaurant</button>
        </form>

        <h3> Delete Category </h3>

        <form id="deleteUserForm">
          <input
            id="deleteCategory"
            data-cy="deleteCategory"
            type="text"
            placeholder="Delete Category by Categoryname:" />
          <br />
          <button
            type="button"
            data-cy="deleteCategoryButton"
            className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
            onClick={() => this.deleteCategory()}>Delete Category</button>
        </form>

        <h3> User </h3>
        <h5>Delete User</h5>
        <form id="deleteUserForm">
        <input
          id="deleteUsername"
            data-cy="deleteUsername"
          type="text"
          placeholder="Delete User by Username:" />
        <br />
        <button
          type="button"
          data-cy="deleteUserButton"
          className="btn btn-danger" style={{ background: "#a73003", color: "#f9e7d9" }}
          onClick={() => this.deleteUser()}>Delete User</button>
        </form>




      </div>

      )
  }

}