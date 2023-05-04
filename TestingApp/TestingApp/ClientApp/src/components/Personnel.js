import React, { Component } from 'react';

export class Personnel extends Component {
    static displayName = Personnel.name;

    constructor(props) {
        super(props);
        this.state = {
            currentPersonnel: null
        };
        this.viewPersonnel = this.viewPersonnel.bind(this);
    }

    viewPersonnel() {
        this.setState({
            currentPersonnel: this.state.currentPersonnel + "doe iets met de state voor dit punt"
        })
    }

    render() {
        return (
            <div>
                <h1>Schedule</h1>

                <p>This is a simple example of a React component.</p>

                <p aria-live="polite">Current Personnel: <strong>{this.state.currentPersonnel}</strong></p>

                <button className="btn btn-primary" onClick={this.viewPersonnel}>View</button>
            </div>
        );
    }
}
