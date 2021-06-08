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
describe('Test Other Functions', () => {

  describe('Navbar', () => {



    it('login navbar', () => {
      cy.visit('/')

      cy.get('[data-cy=navbarLogin').click()

      cy.location('pathname').should('equal', '/login')
    });



    it('home navbar', () => {
      cy.visit('/login')

      cy.get('[data-cy=navbarHome').click()

      cy.location('pathname').should('equal', '/')
    });


  });




  describe('frontPage', () => {




    it('Restaurant-btn  ', () => {
      cy.visit('/')
      cy.get('[data-cy = homeRestaurantsBtn]').click()
      cy.location('pathname').should('equal', '/restaurants')


    });


    it('Categories-btn  ', () => {
      cy.visit('/')
      cy.get('[data-cy = homeCategoriesBtn]').click()
      cy.location('pathname').should('equal', '/categories')


    });



    it('carouselHomeImage  ', () => {
      cy.visit('/')
      cy.get('[data-cy =carouselHomeImage1').should('have.class', 'd-block')
      cy.get('[data-cy =carouselHomeImage2').should('have.class', 'd-block')
      cy.get('[data-cy =carouselHomeImage3').should('have.class', 'd-block')
    });

  });

});