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

describe('Create test account', () => {


  it('Register', () => {

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


  });

  it('Login', () => {

    cy.visit('/')

    cy.get('[data-cy=navbarLogin').click()

    cy.location('pathname').should('equal', '/login')

    cy.get('[data-cy=loginEmail').type(email)

    cy.get('[data-cy=loginPassword').type(password)

    cy.get('[data-cy=submitLogin').click()

    cy.intercept('api/v1/Authentication/Login')

    cy.wait(1000)

  });



});