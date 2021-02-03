import React from 'react';
import { Route } from 'react-router';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import { Counter } from './components/Counter';
import { FetchNewsData } from './components/FetchNews';

import { FetchData } from './components/FetchData';
import { Home } from './components/Home';
import { Layout } from './components/Layout';
import './custom.css';

export default function App() {
    return (
        <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/counter' component={Counter} />
            <Route path='/news' component={FetchNewsData} />
            <AuthorizeRoute path='/fetch-data' component={FetchData} />
            <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
        </Layout>
    );
}
