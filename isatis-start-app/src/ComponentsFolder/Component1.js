import React, { Component } from 'react';
// import logo from './logo.svg';
// import './App.css';
import TestData from '../data/testData.json'

import ComponentDetail from './ComponentDetail';

class Component1 extends Component {
    constructor(props){
        super(props)
        this.dataCallbackHandler = this.dataCallbackHandler.bind(this)
        this.handleRemoveContent = this.handleRemoveContent.bind(this)
        this.state = {
            geneList: []
        }
    }
    handleRemoveContent(geneItem){
        let currentGene = this.state.geneList
        currentGene.pop(geneItem)
        this.setState({
            geneItem: currentGene
        })
    }
    dataCallbackHandler(geneItem){
        // alert(text)
        // console.log(this)
        let currentGene = this.state.geneList
        currentGene.push(geneItem)
        this.setState({
            geneItem: currentGene
        })

    }
    componentDidMount(){
        this.setState({
            geneList: TestData
        })
    }
    render () {
        const {geneList} = this.state
        return (
            <div >
                <h1> Hello there</h1>
                {TestData.map((savedGene, index)=>{
                    return <ComponentDetail 
                    gene={savedGene} 
                    key={`gene-list-key ${index}`}  
                    didHandleRemove={this.handleRemoveContent}
                    dataCallback={this.dataCallbackHandler} />
                })}
            </div>
        )
    }
 } 

export default Component1;
