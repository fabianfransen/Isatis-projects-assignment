import react, { Component } from 'react';
import { QueryClient, QueryClientProvider } from '@tanstack/react-query'

export class Personnel extends Component {

    constructor(props) {
        super(props);
        this.state = {
            plannings: [],
            loading: true
        };
    }

    componentDidMount() {
        this.populateData();
    }

    render() {
        return (
            <div>
                <h1>schedule</h1>

                <p>this is a simple example of a react component.</p>

                <p aria-live="polite">current personnel: <strong>{this.state.plannings.length}</strong></p>

            </div>
        );
    }
    async populateData() {
        const response = await fetch('weatherforecast');
        try {
            const data = await response.json();
            this.setState({ plannings: data, loading: false });
        }
        catch (error) {
            console.error(error);
        }
    }
}
  



