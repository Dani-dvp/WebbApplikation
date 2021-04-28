/// <reference types="Cypress"/>

import { title } from "node:process";

describe('Test all major features', () => {

    it('Registers a new account', () => {

        cy.visit('http://localhost:4100')
        cy.get('[data-cy=register').click()
    
        cy.location('pathname').should('equal', '/register')
    
        cy.get('[data-cy=username').type(username)
        cy.get('[data-cy=password').type(password)
        cy.get('[data-cy=confirmpassword').type(password)
    
        cy.get('[data-cy=email').type(email)
    
        cy.get('[data-cy=submitregistration').submit()
    
        cy.location('pathname').should('equal', '/index2')

        cy.logout()
    });

    

    describe('Logged in functions', () => {
        before(() => {
            cy.login()
        })


        it('Create a restaurant', () => {

            cy.get('[data-cy=writereview').click()
    
            cy.get('[data-cy=addrestaurant').click()

            cy.get('[data-cy=restaurantname').type(restaurant)

            cy.get('[data-cy=location').click()
            .click(500, 500) //No clue if this will work, gotta test it for real

            cy.get('[data-cy=description').type(maintext)

            cy.get('[data-cy=submitrestaurant').click()

    
        });


        it('Create a review', () => {

            cy.get('[data-cy=writereview').click()
    
            cy.get('[data-cy=searchrestaurant').type(restaurant)

            cy.get('[data-cy=review').type(maintext)

            cy.get('[data-cy=fivestar').click()

            cy.get('[data-cy=submitreview').click()

    
        });

        it('Edit a review', () => {

            cy.get('[data-cy=profile').click()
    
            cy.get('[data-cy=editreview').click()

            cy.get('[data-cy=review').type(editedtext)

            cy.get('[data-cy=threestar').click()

            cy.get('[data-cy=submitreview').click()
    
        });


        
    })

    








})