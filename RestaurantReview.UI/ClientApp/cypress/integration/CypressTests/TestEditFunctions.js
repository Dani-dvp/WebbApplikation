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


describe('Edit functions', () => {

  it('Edit a restaurant', () => {

    cy.visit('/AdminPage')

    cy.get('[data-cy=updateRestaurantName').type(restaurant)

    cy.get('[data-cy=updateRestaurantPicture').type(editedPicture)

    cy.get('[data-cy=updateRestaurantWebsite').type(editedWebsite)

    cy.get('[data-cy=updateRestaurantDescription').type(editedWebsite)

    cy.get('[data-cy=updateRestaurantButton').click()

  });

  it('Add Category to restaurant', () => {

    cy.visit('/AdminPage')

    cy.get('[data-cy=AddRestaurantToCategoryName').type(restaurant)

    cy.get('[data-cy=AddCategoryToRestaurantName').type(CategoryName)

    cy.get('[data-cy=AddCategoryToRestaurantButton').click()

  });

});