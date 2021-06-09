/// <reference types="Cypress"/>

const imageUrl = 'https://www.linguahouse.com/linguafiles/md5/d01dfa8621f83289155a3be0970fb0cb'
const CategoryName = 'TestCategory'
const username = 'CypressUser'
const email = 'test@cypressexample.com'
const password = 'Password123!'
const restaurant = 'TestRestaurant'
const maintext = 'This is a test main text'
const rating = '5'
const editedtext = 'This is a test edited text'
const editedPicture = 'https://upload.wikimedia.org/wikipedia/commons/6/62/Barbieri_-_ViaSophia25668.jpg'
const editedWebsite = 'https://www.editedwebsitelink.fake.se'

describe('Create functions', () => {
  
  beforeEach(() => {
    cy.login()
  })

  it('Create a restaurant', () => {

    cy.visit('/')

    cy.get('[data-cy=homeRestaurantsBtn').click()

    cy.location('pathname').should('equal', '/restaurants')

    cy.get('[data-cy=addRestaurant').click()

    cy.location('pathname').should('equal', '/addrestaurant')

    cy.get('[data-cy=addRestaurantName').type(restaurant)

    cy.get('[data-cy=addImageUrl').type(imageUrl)

    cy.get('[data-cy=addRestaurantlink').type(imageUrl)

    cy.get('[data-cy=addDescription').type(maintext)

    cy.get('[data-cy=addCategory').select('American')


    cy.get('[data-cy=submitAddRestaurant').click()
  });






  it('Create a review', () => {

    cy.visit('/AdminPage')


    cy.location('pathname').should('equal', '/AdminPage')

    cy.get('[data-cy=addRestauranttoReviewName').type(restaurant)

    cy.get('[data-cy=userWithReview').type(username)

    cy.get('[data-cy=addReviewtext').type(maintext)

    cy.get('[data-cy=addReviewRating').type(5)

    cy.get('[data-cy=addReviewButton').click()


  });





  it('Create a Category', () => {

    cy.visit('/')

    cy.get('[data-cy=homeCategoriesBtn').click()

    cy.location('pathname').should('equal', '/categories')

    cy.get('[data-cy=addCategoryButton').click()

    cy.location('pathname').should('equal', '/AddCategory')

    cy.get('[data-cy=addCategoryName').type(CategoryName)

    cy.get('[data-cy=submitAddCategory').click()

  });










})