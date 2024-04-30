# terrascript_example.py

from terrascript import Terrascript, resource, provider, variable, output
import json
import os

#from TerraformConfig import TerraformConfig  
# Initialize Terrascript
ts = Terrascript()

ts += resource.aws_instance("my_instance", instance_type="t2.micro")

# Define an AWS provider
ts += provider.aws(region="us-east-1", alias="aws1")

# Define a variable
# Define a variable named "image_id" with type "string"
ts += variable("image_id", type="string")

# Define an output value
# Define an output named "instance_ip_addr" with the value "my_instance.server.private_ip"
ts += output("instance_ip_addr", value="my_instance.server.private_ip")

# Generate JSON output

json_output = json.dumps(ts)

 #config = TerraformConfig()

# Create a TerraformConfig object and populate its properties
#config.Resources = ["my_instance"]
#config.Providers = {"aws1": "us-east-1"}
#config.Variables = {"image_id": "ami-12345678"}
#config.Outputs = {"instance_ip_addr": "10.0.0.1"}

# Print the JSON configuration (for demonstration purposes)

#with open("terraform_config.json", "w") as f:
   # f.write(json_output)

print(ts)
