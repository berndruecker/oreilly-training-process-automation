const { ZBClient } = require('zeebe-node')

// configuration for the Client:
//  - 'baseUrl': url to the Workflow Engine
//  - 'logger': utility to automatically log important events
const client = new ZBClient({
	camundaCloud: {
		clusterId: '9cfc0e64-b2f5-47ee-af0d-64c24341f4b7',
		clientId: 'Yx6Q63H1Nx~tztL-tGo~tAqJfzLI6pkx',
		clientSecret: 'Qj0cv6CYTc5lmYLIlsbv7XhvPMLU--jJbf~loZywSf3UFeULrGoqtV.0-mj85q2R',
	},
})

// create a handler for the task
client.createWorker({
	taskType: 'celebrate',
	taskHandler: (job, _, worker) => {
		const { variables } = job.variables
		worker.log("Yeah, your request was approved and can now be ordered! Please celebrate accordingly!")
		job.complete()
	}
})
