// ***********************************************
// This example commands.js shows you how to
// create various custom commands and overwrite
// existing commands.
//
// For more comprehensive examples of custom
// commands please read more here:
// https://on.cypress.io/custom-commands
// ***********************************************
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
const editedWebsite ='https://www.editedwebsitelink.fake.se'
const reviewId = ''



// -- This is a parent command --
// Cypress.Commands.add('login', (email, password) => { ... })
Cypress.Commands.add('login', () => {

    cy.visit('/')

    cy.get('[data-cy=navbarLogin').click()

    cy.location('pathname').should('equal', '/login')

    cy.get('[data-cy=loginEmail').type(email)

    cy.get('[data-cy=loginPassword').type(password)

    cy.get('[data-cy=submitLogin').click()

    cy.wait(1000)

    

});

 Cypress.Commands.add('logout', () => {

   cy.visit('/')

   cy.get('[data-cy=navbarLogin').click()

   cy.location('pathname').should('equal', '/login')

   cy.get('[data-cy=logoutOnLoginPage').click()
   

 });

 Cypress.Commands.add('register', () => {

    cy.visit('/')
    cy.get('[data-cy=navbarLogin').click()

    cy.location('pathname').should('equal', '/login')

    cy.get('[data-cy=register').click()

    cy.location('pathname').should('equal', '/register')

    cy.get('[data-cy=registerUsername').type(username)
    cy.get('[data-cy=registerEmail').type(email)
    cy.get('[data-cy=registerPassword').type(password)
    cy.get('[data-cy=registerConfirmPassword').type(password)

    cy.get('[data-cy=submitRegistration').click()

    cy.logout()
});

Cypress.Commands.add('deleteUser', () => {

  cy.visit('/AdminPage')

  cy.get('[data-cy=deleteUsername').type(username)


  cy.get('[data-cy=deleteUserButton').click()

});

Cypress.Commands.add('deleteRestaurant', () => {

  cy.visit('/AdminPage')

  cy.get('[data-cy=deleteRestaurantForm').type(restaurant)


  cy.get('[data-cy=deleteRestaurantButton').click()

});


Cypress.Commands.add('deleteCategory', () => {

  cy.visit('/AdminPage')

  cy.get('[data-cy=deleteCategory').type(CategoryName)

  cy.get('[data-cy=deleteCategoryButton').click()

});





//
// -- This is a child command --
// Cypress.Commands.add('drag', { prevSubject: 'element'}, (subject, options) => { ... })
//
//
// -- This is a dual command --
// Cypress.Commands.add('dismiss', { prevSubject: 'optional'}, (subject, options) => { ... })
//
//
// -- This will overwrite an existing command --
// Cypress.Commands.overwrite('visit', (originalFn, url, options) => { ... })
