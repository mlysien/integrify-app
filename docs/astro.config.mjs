import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';

// https://astro.build/config
export default defineConfig({
  	site: 'https://mlysien.github.io/integrify',
  	base: 'integrify',
	icon: '/public/favicon.ico',
  	integrations: [
		starlight({
			
			title: 'integrify',
			social: {
				github: 'https://github.com/mlysien/integrify',
			},
			sidebar: [
				{
					label: 'Overview',
					items: [
						{ label: 'About', link: '/overview/about' },
						{ label: 'Motivation', link: '/overview/motivation' }
					],
				},
				{
					label: 'Architecture',
					items: [
						{ label: 'Approach', link: '/architecture/approach' },
						{ label: 'Integrations', link: '/architecture/integrations' },
						{ label: 'Plugins', link: '/architecture/plugins' },
						{ label: 'Adapters', link: '/architecture/adapters' },
						{ label: 'Ports', link: '/architecture/ports' }
					],
				},
				{
					label: 'How to use?',
					items: [
						{ label: 'CLI', link: '/architecture/concept' },
						{ label: 'Self-develop', link: '/architecture/adapters' },
					],
				}
			],
		}),
	],
});
