1) Create en empty folder and copy to it 'docker-compose(for final test on another PC).yml' file (after that rename it like 'docker-compose.yml')
2) Run Sql Server Config Manager and do the following: SQL Server Network Config -> Protocols for SQLEXPRESS -> TCP/IP -> tab IP Addresses -> add TCP Port - 61300 to IPAII -> Apply + OK -> rightclick on TCP/IP -> Enable it -> Restart SQL Server
3) Run Windows Defender Firewall with Advanced Security and add a new rule into Inbound Rules. Click New Rule... -> Choose Port + Next -> Choose TCP + Specific local ports and add 61300 here + Next -> Allow the connection + Next + Next -> Write any name + Finish
4) Run PowerShell cd the folder with .yml file and run docker-compose up
