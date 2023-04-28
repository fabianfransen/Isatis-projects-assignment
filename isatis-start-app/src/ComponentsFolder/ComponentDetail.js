import React, { Component } from 'react';
// import logo from './logo.svg';
// import './App.css';

class ComponentDetail extends Component {
    constructor(props){
        super(props)
        this.ensembleIDClickEvent = this.ensembleIDClickEvent.bind(this)
        this.toggleContent = this.toggleContent.bind(this)
        this.state = {
            showContent: true
        }

    }
    ensembleIDClickEvent(event){
        event.preventDefault()
        console.log(this.ensembleIDClickEvent)
        const {dataCallback} = this.props
        if (dataCallback !== undefined) {
            dataCallback("callback")
        }
    }

    toggleContent (event) {
        // prevent the default
        event.preventDefault()
        this.setState({
            showContent: !this.state.showContent
        })
    }
    render () {
        const {gene} = this.props
        const {showContent} = this.state
        return (
            <div>
                <h1 onClick={this.ensembleIDClickEvent}> {gene.ensemblID} </h1>
                // d-block bootstrap
                /<p className={` ${showContent === true ? 'd-block' : 'd-none' }`}>{gene.geneName}</p>                                          
                {showContent === true ? <p>{gene.geneName}</p> : ""}
                {showContent === true ? <p>{gene.speciesName}</p> : ""}
                {showContent === true ? <p>{gene.source}</p> : ""}
                <button onClick={this.toggleContent}> Toggle content display </button>
            </div>
        )
    }
 }

export default ComponentDetail;
