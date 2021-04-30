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

        const username = 'CypressTest'
        const email = 'cypress@email.com'
        const password = 'CypressPassword'
        const restaurant = 'ExampleRestaurant'
        const title = 'This is a review'
        const maintext = 'This is the main text'
        const rating = '5'
        const editedtext = 'This is a edited text'



// -- This is a parent command --
// Cypress.Commands.add('login', (email, password) => { ... })
Cypress.Commands.add('login', (username, password) => {

    cy.visit('http://localhost:4100')

    cy.contains('[data-cy=login').click()

    cy.location('pathname').should('equal', '/login')

    cy.get('[data-cy=username').type(username)

    cy.get('[data-cy=password').type(password)

    cy.contains('[data-cy=submitlogin').click()

    cy.location('pathname').should('equal', '/index2')
})

Cypress.Commands.add('logout', () => {

    cy.visit('http://localhost:4100')

    cy.contains('[data-cy=profile').click()

    cy.location('pathname').should('equal', '/loggedin')

    cy.contains('.nav-link', 'Login').should('not.have.class', 'nav-link')

    cy.contains('[data-cy=logout').click()

    cy.location('pathname').should('equal', '/index')

    cy.contains('.nav-link', 'Login').should('have.class', 'nav-link')

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
