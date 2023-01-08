<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
			<body>
				<h1 style="background-color: red; color: white; font-size: 18pt; text-align: center">
					Persons
				</h1>
				<table border="1">
					<tr style="font-size: 12pt; font-family: verdana; font-weight: bold">
						<td style="text-align: center">First</td>
						<td style="text-align: center">Last</td>
						<td style="text-align: center">Id</td>
						<td style="text-align: center">Password</td>
						<td style="text-align: center">Encryption</td>
						<td style="text-align: center">Work</td>
						<td style="text-align: center">Cell</td>
						<td style="text-align: center">Provider</td>
						<td style="text-align: center">Category</td>
					</tr>
					<xsl:for-each select="Persons/Person">
						<tr style="font-size: 12pt; font-family: verdana">
							<xsl:for-each select="Name">
								<td>
										<xsl:value-of select="First"/>
								</td>
								<td>
									<xsl:value-of select="Last"/>
								</td>
							</xsl:for-each>
							<xsl:for-each select="Credential">
								<td>
									<xsl:value-of select="Id"/>
								</td>
								<td>
									<xsl:value-of select="Password"/>
								</td>
								<td>
									<xsl:value-of select="Password/@Encryption"/>
								</td>
							</xsl:for-each>
							<xsl:for-each select="Phone">
								<td>
									<xsl:value-of select="Work"/>
								</td>
								<td>
									<xsl:value-of select="Cell"/>
								</td>
								<td>
									<xsl:value-of select="Cell/@Provider"/>
								</td>
							</xsl:for-each>
							<td>
								<xsl:value-of select="Category"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>