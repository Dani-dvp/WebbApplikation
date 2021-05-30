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

const username = 'testuser'
const email = 'test@example.com'
const password = 'Password123!'
const restaurant = 'Fiskekrogen'
const title = 'This is a title'
const maintext = 'This is the main text'
const rating = '5'
const editedtext = 'This is a edited text'



// -- This is a parent command --
// Cypress.Commands.add('login', (email, password) => { ... })
Cypress.Commands.add('login', () => {

    cy.visit('/')

    cy.get('[data-cy=navbarLogin').click()

    cy.location('pathname').should('equal', '/login')

    cy.get('[data-cy=loginEmail').type(email)

    cy.get('[data-cy=loginPassword').type(password)

    cy.get('[data-cy=submitLogin').click()

})

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
