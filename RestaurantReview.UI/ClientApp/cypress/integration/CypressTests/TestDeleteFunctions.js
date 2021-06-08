/// <reference types="Cypress"/>

const imageUrl = 'https://www.linguahouse.com/linguafiles/md5/d01dfa8621f83289155a3be0970fb0cb'
const CategoryName = 'testCategory'
const username = 'CypressUser'
const email = 'test@cypressexample.com'
const password = 'Password123!'
const restaurant = 'TestRestaurant'
const maintext = 'This is a test main text'
const rating = '5'
const editedtext = 'This is a test edited text'
const editedPicture = 'https://upload.wikimedia.org/wikipedia/commons/6/62/Barbieri_-_ViaSophia25668.jpg'
const editedWebsite = 'https://www.editedwebsitelink.fake.se'


describe('Reset state', () => {
  beforeEach(() => {
    cy.login()
  })




  it('Delete restaurant  ', () => {
    cy.visit('/AdminPage')

    cy.get('[data-cy=deleteRestaurantForm').type(restaurant)


    cy.get('[data-cy=deleteRestaurantButton').click()

  });


  it('Delete categories  ', () => {
    cy.visit('/AdminPage')

    cy.get('[data-cy=deleteCategory').type(CategoryName)

    cy.get('[data-cy=deleteCategoryButton').click()

  });



  it('Delete user  ', () => {
    cy.visit('/AdminPage')

    cy.get('[data-cy=deleteUsername').type(username)


    cy.get('[data-cy=deleteUserButton').click()
  });




});