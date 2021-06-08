/// <reference types="Cypress"/>


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